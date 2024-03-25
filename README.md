# LegoNet

This is a basic MVC app that I have created while I was learning C# over the last couple of days. I already had a Postgres database that I use for my Lego collection app which I have written using Scala and the Play framework.

In the app I have defined three model classes: `Colour`, `Category` and `Set`.

`Colour` is a stand-alone class which I created first to understand how to do some basic things with Entity Framework.

`Set` represents an actual Lego set and has a dependency on `Category`. (For example, a "Hogwarts Castle" set might have a category of "Harry Potter".) The relationship between `Set` and `Category` is modelled with a foreign key.

As the naming conventions in Postgres are different to what it would expect, I have to map the column names, etc.

Each of the entities (except `Category`) has a corresponding controller with the `Index` action showing a list of the rows for each entity.

Although simple, I've probably only spent a day and a half working on this, so it hasn't taken long to get some of the basics down. If I were to continue to learn C# and .NET, I would extend this app to do more things, such as having access to details of individual Lego parts and then which parts are contained in each set. My Scala app integrates with an API provided by bricklink.com, and I would want to make some use of this, as well as to provide my own API alongside the existing views.
