namespace RoutingExample

module Route =

  open System

  let (~~) (x:obj) =
    match x with
    | :? 't as t -> t
    | _ -> null

  type IRoute =

    abstract member Handle: obj -> obj

    abstract member GetParamType: unit -> Type

  [<AbstractClass>]
  type Route<'TIn, 'TOut when 'TIn : null>() =

    abstract member Handle: 'TIn -> 'TOut

    interface IRoute with

      member this.Handle(param: obj) =
        this.Handle(~~param:'TIn) :> obj

      member this.GetParamType() =
        typeof<'TIn>
