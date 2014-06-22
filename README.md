This started as a standard way of setting up most projects I work on. The folder 
structure provides a quick template to get an empty solution working. When I am
less busy and lazy I will create a Visual Studio template for this. Then I can 
get a new project up with this structure just by creating a new solution.

I also started on some core interfaces and infrastructure that is common across
projects. The goal is that I can include these projects and get the base core
architecture without having to rewrite it. There is still a lot to do. I am a
big fan of the [Onion Architecture](http://jeffreypalermo.com/blog/the-onion-architecture-part-1/) and 
the goal of this little project is to eventually grown into an implementation of
Onion.