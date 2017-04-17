module MorseCodeTranslator

open Fable.Core
open Fable.Import
open Elmish
open Fable.PowerPack
open Fable.PowerPack.Fetch
open Fable.PowerPack.Fetch.Fetch_types
module R = Fable.Helpers.React
open Fable.Core.JsInterop
open Fable.Helpers.React.Props
open Elmish.React
open Fable.Helpers.React
open Fable.Import.Browser

type EnglishCharacter = EnglishCharacter of char
type MorseCharacter = 
    | Dot
    | Dash

type Model = {
    EnglishCharacters : EnglishCharacter list
    MorseCharacters : MorseCharacter list
}

type Msg =
    | CharEntered of string

let init () = {EnglishCharacters = []; MorseCharacters = [];}

let update msg model = 
    match msg with
    | CharEntered str -> 
        model

let view model dispatch =
    R.div [ ] [
        R.h1 [] [ R.str "todos" ]
        R.input [
            ClassName "new-todo"
            Placeholder "What needs to be done?"
            OnChange (fun (ev:React.FormEvent) -> !!ev.target?value |> CharEntered |> dispatch)
        ]
    ]

Program.mkSimple init update view
|> Program.withConsoleTrace
|> Program.withReact "app"
|> Program.run


