# FluentBootstrapCore

## Overview

This project is "NetCore" version of FluentBootstrap (https://github.com/daveaglick/FluentBootstrap). This has not been completed yet. I would be glad if any developer would like to participate in development of this solution. 


## Example

FluentBootstrap lets you output this:

```
<nav class="navbar-static-top navbar-default navbar" 
 id="navbar" role="navigation">
 <div class="container-fluid">
  <div class="navbar-header">
   <a class="navbar-brand" href="#">FluentBootstrap</a>
   <button class="collapsed navbar-toggle" data-target="#navbar-collapse"
    data-toggle="collapse" type="button">
    <span class="sr-only">Toggle Navigation</span>
    <span class="icon-bar"></span>
    <span class="icon-bar"></span>
    <span class="icon-bar"></span>
   </button>
  </div>
  <div class="collapse navbar-collapse" id="navbar-collapse">
   <div class="navbar-left navbar-nav nav">
    <li><a href="/">Introduction</a></li>
    <li><a href="/Installation">Installation</a></li>
    <li><a href="/Usage">Usage</a></li>
    <li><a href="/Development">Development</a></li>
   </div>
  </div>
 </div>
</nav>
```

By writing this (for example, if using from an ASP.NET MVC view):

```
@using (var navbar = Html.Bootstrap().Navbar("FluentBootstrap")
    .SetPosition(NavbarPosition.StaticTop).Begin())
{
    @navbar.NavbarLink("Introduction", "/")
    @navbar.NavbarLink("Installation", "/Installation")
    @navbar.NavbarLink("Usage", "/Usage")
    @navbar.NavbarLink("Development", "/Development")
}
```