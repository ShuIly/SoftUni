package teistermask.controller;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import teistermask.entity.Task;
import teistermask.repository.TaskRepository;

import java.util.List;
import java.util.stream.Collectors;

@Controller
public class TaskController {
	private final TaskRepository taskRepository;

	@Autowired
	public TaskController(TaskRepository taskRepository) {
		this.taskRepository = taskRepository;
	}

	@GetMapping("/")
	public String index(Model model) {
        List<Task> tasks = taskRepository.findAll();

        model.addAttribute("openTasks", tasks.stream()
				.filter(t -> t.getStatus().equals("Open"))
				.collect(Collectors.toList()));

		model.addAttribute("inProgressTasks", tasks.stream()
				.filter(t -> t.getStatus().equals("In Progress"))
				.collect(Collectors.toList()));

		model.addAttribute("finishedTasks", tasks.stream()
				.filter(t -> t.getStatus().equals("Finished"))
				.collect(Collectors.toList()));

        model.addAttribute("view", "task/index");

        return "base-layout";	}

	@GetMapping("/create")
	public String create(Model model) {
		model.addAttribute("view", "task/create");

		return "base-layout";
	}

	// See if BindingModel is any different before changing it to Task!
	@PostMapping("/create")
	public String createProcess(Model model, Task task) {
	    if (task.getTitle().equals("") || task.getStatus().equals("")) {
	    	model.addAttribute("task", task);
			model.addAttribute("view", "task/create");

			return "base-layout";
		}

		taskRepository.saveAndFlush(task);

		return "redirect:/";
	}

	@GetMapping("/edit/{id}")
	public String edit(Model model, @PathVariable int id) {
	    Task task = taskRepository.findOne(id);

	    if (task == null) {
	    	return "redirect:/";
		}

		model.addAttribute("task", task);
		model.addAttribute("view", "task/edit");

		return "base-layout";
	}

	// See if BindingModel is any different before changing it to Task!
	@PostMapping("/edit/{id}")
	public String editProcess(Model model, @PathVariable int id, Task taskModel) {
	    if (taskModel.getTitle().equals("") || taskModel.getStatus().equals("")) {
	    	taskModel.setId(id);

	    	model.addAttribute("taskModel", taskModel);
			model.addAttribute("view", "task/edit");

			return "base-layout";
		}

		Task task = taskRepository.findOne(id);
	    if (task != null) {
	        task.setTitle(taskModel.getTitle());
			task.setStatus(taskModel.getStatus());
			taskRepository.saveAndFlush(task);
		}

		return "redirect:/";
	}
}
