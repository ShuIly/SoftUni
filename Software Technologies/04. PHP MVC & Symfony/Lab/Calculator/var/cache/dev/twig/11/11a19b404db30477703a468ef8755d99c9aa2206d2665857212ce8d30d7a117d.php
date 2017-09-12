<?php

/* @WebProfiler/Collector/exception.html.twig */
class __TwigTemplate_e47e2a84d34e3d619a4e2387636001ba30ec292b56bdd881a0e395fc27296bef extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        // line 1
        $this->parent = $this->loadTemplate("@WebProfiler/Profiler/layout.html.twig", "@WebProfiler/Collector/exception.html.twig", 1);
        $this->blocks = array(
            'head' => array($this, 'block_head'),
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
        $__internal_35895af347a0e17bd76f6ffda6d54a79a02a45712eceacd9d5bdd6946c303d4d = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_35895af347a0e17bd76f6ffda6d54a79a02a45712eceacd9d5bdd6946c303d4d->enter($__internal_35895af347a0e17bd76f6ffda6d54a79a02a45712eceacd9d5bdd6946c303d4d_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@WebProfiler/Collector/exception.html.twig"));

        $this->parent->display($context, array_merge($this->blocks, $blocks));
        
        $__internal_35895af347a0e17bd76f6ffda6d54a79a02a45712eceacd9d5bdd6946c303d4d->leave($__internal_35895af347a0e17bd76f6ffda6d54a79a02a45712eceacd9d5bdd6946c303d4d_prof);

    }

    // line 3
    public function block_head($context, array $blocks = array())
    {
        $__internal_f0bb4c59e3e893cfa24af20c4870c6cb14b618717619096514838c045aec4605 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_f0bb4c59e3e893cfa24af20c4870c6cb14b618717619096514838c045aec4605->enter($__internal_f0bb4c59e3e893cfa24af20c4870c6cb14b618717619096514838c045aec4605_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "head"));

        // line 4
        echo "    ";
        if ($this->getAttribute((isset($context["collector"]) ? $context["collector"] : $this->getContext($context, "collector")), "hasexception", array())) {
            // line 5
            echo "        <style>
            ";
            // line 6
            echo $this->env->getExtension('Symfony\Bridge\Twig\Extension\HttpKernelExtension')->renderFragment($this->env->getExtension('Symfony\Bridge\Twig\Extension\RoutingExtension')->getPath("_profiler_exception_css", array("token" => (isset($context["token"]) ? $context["token"] : $this->getContext($context, "token")))));
            echo "
        </style>
    ";
        }
        // line 9
        echo "    ";
        $this->displayParentBlock("head", $context, $blocks);
        echo "
";
        
        $__internal_f0bb4c59e3e893cfa24af20c4870c6cb14b618717619096514838c045aec4605->leave($__internal_f0bb4c59e3e893cfa24af20c4870c6cb14b618717619096514838c045aec4605_prof);

    }

    // line 12
    public function block_menu($context, array $blocks = array())
    {
        $__internal_12479e321cb53f5c67840c0fac3521a1a6ff05101cad8012bd51c62a7b271e9c = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_12479e321cb53f5c67840c0fac3521a1a6ff05101cad8012bd51c62a7b271e9c->enter($__internal_12479e321cb53f5c67840c0fac3521a1a6ff05101cad8012bd51c62a7b271e9c_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "menu"));

        // line 13
        echo "    <span class=\"label ";
        echo (($this->getAttribute((isset($context["collector"]) ? $context["collector"] : $this->getContext($context, "collector")), "hasexception", array())) ? ("label-status-error") : ("disabled"));
        echo "\">
        <span class=\"icon\">";
        // line 14
        echo twig_include($this->env, $context, "@WebProfiler/Icon/exception.svg");
        echo "</span>
        <strong>Exception</strong>
        ";
        // line 16
        if ($this->getAttribute((isset($context["collector"]) ? $context["collector"] : $this->getContext($context, "collector")), "hasexception", array())) {
            // line 17
            echo "            <span class=\"count\">
                <span>1</span>
            </span>
        ";
        }
        // line 21
        echo "    </span>
";
        
        $__internal_12479e321cb53f5c67840c0fac3521a1a6ff05101cad8012bd51c62a7b271e9c->leave($__internal_12479e321cb53f5c67840c0fac3521a1a6ff05101cad8012bd51c62a7b271e9c_prof);

    }

    // line 24
    public function block_panel($context, array $blocks = array())
    {
        $__internal_dbd73e913e867e1680ceec44bcfa29ced1c2fab5551a291c41cf39e5c9085e29 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_dbd73e913e867e1680ceec44bcfa29ced1c2fab5551a291c41cf39e5c9085e29->enter($__internal_dbd73e913e867e1680ceec44bcfa29ced1c2fab5551a291c41cf39e5c9085e29_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "panel"));

        // line 25
        echo "    <h2>Exceptions</h2>

    ";
        // line 27
        if ( !$this->getAttribute((isset($context["collector"]) ? $context["collector"] : $this->getContext($context, "collector")), "hasexception", array())) {
            // line 28
            echo "        <div class=\"empty\">
            <p>No exception was thrown and caught during the request.</p>
        </div>
    ";
        } else {
            // line 32
            echo "        <div class=\"sf-reset\">
            ";
            // line 33
            echo $this->env->getExtension('Symfony\Bridge\Twig\Extension\HttpKernelExtension')->renderFragment($this->env->getExtension('Symfony\Bridge\Twig\Extension\RoutingExtension')->getPath("_profiler_exception", array("token" => (isset($context["token"]) ? $context["token"] : $this->getContext($context, "token")))));
            echo "
        </div>
    ";
        }
        
        $__internal_dbd73e913e867e1680ceec44bcfa29ced1c2fab5551a291c41cf39e5c9085e29->leave($__internal_dbd73e913e867e1680ceec44bcfa29ced1c2fab5551a291c41cf39e5c9085e29_prof);

    }

    public function getTemplateName()
    {
        return "@WebProfiler/Collector/exception.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  117 => 33,  114 => 32,  108 => 28,  106 => 27,  102 => 25,  96 => 24,  88 => 21,  82 => 17,  80 => 16,  75 => 14,  70 => 13,  64 => 12,  54 => 9,  48 => 6,  45 => 5,  42 => 4,  36 => 3,  11 => 1,);
    }

    public function getSource()
    {
        return "{% extends '@WebProfiler/Profiler/layout.html.twig' %}

{% block head %}
    {% if collector.hasexception %}
        <style>
            {{ render(path('_profiler_exception_css', { token: token })) }}
        </style>
    {% endif %}
    {{ parent() }}
{% endblock %}

{% block menu %}
    <span class=\"label {{ collector.hasexception ? 'label-status-error' : 'disabled' }}\">
        <span class=\"icon\">{{ include('@WebProfiler/Icon/exception.svg') }}</span>
        <strong>Exception</strong>
        {% if collector.hasexception %}
            <span class=\"count\">
                <span>1</span>
            </span>
        {% endif %}
    </span>
{% endblock %}

{% block panel %}
    <h2>Exceptions</h2>

    {% if not collector.hasexception %}
        <div class=\"empty\">
            <p>No exception was thrown and caught during the request.</p>
        </div>
    {% else %}
        <div class=\"sf-reset\">
            {{ render(path('_profiler_exception', { token: token })) }}
        </div>
    {% endif %}
{% endblock %}
";
    }
}
