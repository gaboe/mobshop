namespace MobShop

module HttpHandlers =

    open Microsoft.AspNetCore.Http
    open FSharp.Control.Tasks.V2.ContextInsensitive
    open Giraffe
    open MobShop.Models

    let handleGetHello =
        fun (next : HttpFunc) (ctx : HttpContext) ->
            task {
                let response = {
                    Text = "Hello world, from Giraffe!"
                }
                return! json response next ctx
            }