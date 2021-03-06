﻿namespace RoutingExample

module main =

  open System
  open Operators.CastOperators
  open Route
  open ExampleRoute

  [<EntryPoint>]
  let main argv =
    let route = new ExampleRoute() :> IRoute
    printfn "%s" (~~(route.Handle "hello"):string)
    0
