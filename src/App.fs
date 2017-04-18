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
open Translator

type Model = {
    MorseCharacters : string
}

type Msg =
    | CharEntered of string

let init () = {MorseCharacters = "";}



let update msg model = 
    match msg with
    | CharEntered str -> 
        {model with MorseCharacters = (str |> List.ofSeq |> List.map (fun x -> EnglishCharacter x))}

let view model dispatch =
    R.div [ ] [
        R.h1 [] [ R.str "Enter text to be converted to morse code" ]
        R.input [
            ClassName "new-todo"
            Placeholder "What needs to be done?"
            OnChange (fun (ev:React.FormEvent) -> !!ev.target?value |> CharEntered |> dispatch)
        ]
        R.h2 [][
            R.str ""
        ]
    ]

Program.mkSimple init update view
|> Program.withConsoleTrace
|> Program.withReact "app"
|> Program.run


