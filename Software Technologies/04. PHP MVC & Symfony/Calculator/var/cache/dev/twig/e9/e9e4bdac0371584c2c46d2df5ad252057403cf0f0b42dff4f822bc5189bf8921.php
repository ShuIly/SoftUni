<?php

/* form/fields.html.twig */
class __TwigTemplate_bb3509a246403cc68e7e70fc05949ff272366e5b62b17865ba95aa71f7e94b96 extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        $this->parent = false;

        $this->blocks = array(
            'date_time_picker_widget' => array($this, 'block_date_time_picker_widget'),
        );
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_611feb5de7478a60675a5b9e60293d49275e803e4cfd7cb86ae0a2415bd7ee98 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_611feb5de7478a60675a5b9e60293d49275e803e4cfd7cb86ae0a2415bd7ee98->enter($__internal_611feb5de7478a60675a5b9e60293d49275e803e4cfd7cb86ae0a2415bd7ee98_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "form/fields.html.twig"));

        // line 9
        echo "
";
        // line 10
        $this->displayBlock('date_time_picker_widget', $context, $blocks);
        
        $__internal_611feb5de7478a60675a5b9e60293d49275e803e4cfd7cb86ae0a2415bd7ee98->leave($__internal_611feb5de7478a60675a5b9e60293d49275e803e4cfd7cb86ae0a2415bd7ee98_prof);

    }

    public function block_date_time_picker_widget($context, array $blocks = array())
    {
        $__internal_5d291d5243aa2067a08f255aca0e45a80edc49ae8e4ebc512b93d533949677ac = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_5d291d5243aa2067a08f255aca0e45a80edc49ae8e4ebc512b93d533949677ac->enter($__internal_5d291d5243aa2067a08f255aca0e45a80edc49ae8e4ebc512b93d533949677ac_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "date_time_picker_widget"));

        // line 11
        echo "    ";
        ob_start();
        // line 12
        echo "        <div class=\"input-group date\" data-toggle=\"datetimepicker\">
            ";
        // line 13
        $this->displayBlock("datetime_widget", $context, $blocks);
        echo "
            ";
        // line 15
        echo "                ";
        // line 16
        echo "            ";
        // line 17
        echo "        </div>
    ";
        echo trim(preg_replace('/>\s+</', '><', ob_get_clean()));
        
        $__internal_5d291d5243aa2067a08f255aca0e45a80edc49ae8e4ebc512b93d533949677ac->leave($__internal_5d291d5243aa2067a08f255aca0e45a80edc49ae8e4ebc512b93d533949677ac_prof);

    }

    public function getTemplateName()
    {
        return "form/fields.html.twig";
    }

    public function getDebugInfo()
    {
        return array (  52 => 17,  50 => 16,  48 => 15,  44 => 13,  41 => 12,  38 => 11,  26 => 10,  23 => 9,);
    }

    public function getSource()
    {
        return "{#
   Each field type is rendered by a template fragment, which is determined
   by the name of your form type class (DateTimePickerType -> date_time_picker)
   and the suffix \"_widget\". This can be controlled by overriding getBlockPrefix()
   in DateTimePickerType.

   See http://symfony.com/doc/current/cookbook/form/create_custom_field_type.html#creating-a-template-for-the-field
#}

{% block date_time_picker_widget %}
    {% spaceless %}
        <div class=\"input-group date\" data-toggle=\"datetimepicker\">
            {{ block('datetime_widget') }}
            {#<span class=\"input-group-addon\">#}
                {#<span class=\"fa fa-calendar\" aria-hidden=\"true\"></span>#}
            {#</span>#}
        </div>
    {% endspaceless %}
{% endblock %}
";
    }
}
