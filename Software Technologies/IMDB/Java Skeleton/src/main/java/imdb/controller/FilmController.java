package imdb.controller;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import imdb.bindingModel.FilmBindingModel;
import imdb.entity.Film;
import imdb.repository.FilmRepository;

import java.util.List;

@Controller
public class FilmController {

	private final FilmRepository filmRepository;

	@Autowired
	public FilmController(FilmRepository filmRepository) {
	    this.filmRepository = filmRepository;
	}

	@GetMapping("/")
	public String index(Model model) {
	    List<Film> films = this.filmRepository.findAll();

	    model.addAttribute("view", "film/index");
		model.addAttribute("films", films);

		return "base-layout";
	}

	@GetMapping("/create")
	public String create(Model model) {
		//TODO: Implement me ...
		return null;
	}

	@PostMapping("/create")
	public String createProcess(Model model, FilmBindingModel filmBindingModel) {
		//TODO: Implement me ...
		return null;
	}

	@GetMapping("/edit/{id}")
	public String edit(Model model, @PathVariable int id) {
		//TODO: Implement me ...
		return null;
	}

	@PostMapping("/edit/{id}")
	public String editProcess(Model model, @PathVariable int id, FilmBindingModel filmBindingModel) {
		//TODO: Implement me ...
		return null;
	}

	@GetMapping("/delete/{id}")
	public String delete(Model model, @PathVariable int id) {
		//TODO: Implement me ...
		return null;
	}

	@PostMapping("/delete/{id}")
	public String deleteProcess(@PathVariable int id) {
		//TODO: Implement me ...
		return null;
	}
}
