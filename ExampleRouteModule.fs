namespace RoutingExample

module ExampleRoute =

  open System
  open Route

  type ExampleRoute() =

    inherit Route<string, string>()

    override this.Handle(param: string) =
      param + " world"
