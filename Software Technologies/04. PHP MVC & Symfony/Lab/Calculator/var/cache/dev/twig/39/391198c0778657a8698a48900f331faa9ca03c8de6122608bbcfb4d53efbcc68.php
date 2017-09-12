<?php

/* @WebProfiler/Collector/router.html.twig */
class __TwigTemplate_813b4838381dd89ff8b0c56bf22eee96cb8009fdcf3825994ba89e1c6104e531 extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        // line 1
        $this->parent = $this->loadTemplate("@WebProfiler/Profiler/layout.html.twig", "@WebProfiler/Collector/router.html.twig", 1);
        $this->blocks = array(
            'toolbar' => array($this, 'block_toolbar'),
            'menu' => array($this, 'block_menu'),
            'panel' => array($this, 'block_panel'),
        );
    }

    protected function doGetParent(array $context)
    {
        return "@WebProfiler/Profiler/layout.html.twig";
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_fae7b13cedd5e19d72775b80819f88cfe077f8e9455b8099e8623d55a622d776 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_fae7b13cedd5e19d72775b80819f88cfe077f8e9455b8099e8623d55a622d776->enter($__internal_fae7b13cedd5e19d72775b80819f88cfe077f8e9455b8099e8623d55a622d776_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@WebProfiler/Collector/router.html.twig"));

        $this->parent->display($context, array_merge($this->blocks, $blocks));
        
        $__internal_fae7b13cedd5e19d72775b80819f88cfe077f8e9455b8099e8623d55a622d776->leave($__internal_fae7b13cedd5e19d72775b80819f88cfe077f8e9455b8099e8623d55a622d776_prof);

    }

    // line 3
    public function block_toolbar($context, array $blocks = array())
    {
        $__internal_1eec17a2827d506afcbf0b3f3280786eb58ecb4ec287e258cb5e34626638931b = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_1eec17a2827d506afcbf0b3f3280786eb58ecb4ec287e258cb5e34626638931b->enter($__internal_1eec17a2827d506afcbf0b3f3280786eb58ecb4ec287e258cb5e34626638931b_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "toolbar"));

        
        $__internal_1eec17a2827d506afcbf0b3f3280786eb58ecb4ec287e258cb5e34626638931b->leave($__internal_1eec17a2827d506afcbf0b3f3280786eb58ecb4ec287e258cb5e34626638931b_prof);

    }

    // line 5
    public function block_menu($context, array $blocks = array())
    {
        $__internal_306142bfb3e11f3db867b326dc035fdb42da1cfc91e5c3a781ba0c3c74ed907e = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_306142bfb3e11f3db867b326dc035fdb42da1cfc91e5c3a781ba0c3c74ed907e->enter($__internal_306142bfb3e11f3db867b326dc035fdb42da1cfc91e5c3a781ba0c3c74ed907e_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "menu"));

        // line 6
        echo "<span class=\"label\">
    <span class=\"icon\">";
        // line 7
        echo twig_include($this->env, $context, "@WebProfiler/Icon/router.svg");
        echo "</span>
    <strong>Routing</strong>
</span>
";
        
        $__internal_306142bfb3e11f3db867b326dc035fdb42da1cfc91e5c3a781ba0c3c74ed907e->leave($__internal_306142bfb3e11f3db867b326dc035fdb42da1cfc91e5c3a781ba0c3c74ed907e_prof);

    }

    // line 12
    public function block_panel($context, array $blocks = array())
    {
        $__internal_c8a5107f9d45215e2374331307a5199444e2526ef1c7df72f6917eeebee03111 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_c8a5107f9d45215e2374331307a5199444e2526ef1c7df72f6917eeebee03111->enter($__internal_c8a5107f9d45215e2374331307a5199444e2526ef1c7df72f6917eeebee03111_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "panel"));

        // line 13
        echo "    ";
        echo $this->env->getExtension('Symfony\Bridge\Twig\Extension\HttpKernelExtension')->renderFragment($this->env->getExtension('Symfony\Bridge\Twig\Extension\RoutingExtension')->getPath("_profiler_router", array("token" => (isset($context["token"]) ? $context["token"] : $this->getContext($context, "token")))));
        echo "
";
        
        $__internal_c8a5107f9d45215e2374331307a5199444e2526ef1c7df72f6917eeebee03111->leave($__internal_c8a5107f9d45215e2374331307a5199444e2526ef1c7df72f6917eeebee03111_prof);

    }

    public function getTemplateName()
    {
        return "@WebProfiler/Collector/router.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  73 => 13,  67 => 12,  56 => 7,  53 => 6,  47 => 5,  36 => 3,  11 => 1,);
    }

    public function getSource()
    {
        return "{% extends '@WebProfiler/Profiler/layout.html.twig' %}

{% block toolbar %}{% endblock %}

{% block menu %}
<span class=\"label\">
    <span class=\"icon\">{{ include('@WebProfiler/Icon/router.svg') }}</span>
    <strong>Routing</strong>
</span>
{% endblock %}

{% block panel %}
    {{ render(path('_profiler_router', { token: token })) }}
{% endblock %}
";
    }
}
