# Behavior Trees

This repository implements stateless behavior trees via *active logic*. This is a reference implementation; for serious work, prefer the [active logic library](https://github.com/active-logic/activelogic-cs).

Sources are provided in C# and [Howl](https://github.com/active-logic/howl) notation.

The core implementation is self-contained; you may include [status.cs](cs/src/Status.cs) into your project.

Implementations:
- [C# reference implementation](cs/src/Status.cs)
- [Howl reference implementation](howl/src/Status.howl)

The internal structure of this repository may change in the future. External links should be pointing at https://github.com/eelstork/behaviortrees

## Building, running tests etc

`cd` to the *cs* directory then `dotnet build`, `dotnet test`, ...
