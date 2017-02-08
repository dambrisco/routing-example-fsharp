namespace Operators

module CastOperators =

  let (~~) (x:obj) =
    match x with
    | :? 't as t -> t
    | _ -> null
