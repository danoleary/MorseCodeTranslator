module Translator

open System

type MorseSymbol = 
    | Dot
    | Dash
    | Space

type MorseCharacter =
    MorseSymbol list

let ConvertCharToEnglishChar = function
    | 'A' | 'a' -> [Dot; Dash]
    | 'B' | 'b' -> [Dash; Dot; Dot; Dot]
    | 'C' | 'c' -> [Dash; Dot; Dash; Dot]
    | 'D' | 'd' -> [Dash; Dot; Dot]
    | 'E' | 'e' -> [Dot]
    | 'F' | 'f' -> [Dot; Dot; Dash; Dot]
    | 'G' | 'g' -> [Dash; Dash; Dot]
    | 'H' | 'h' -> [Dot; Dot; Dot; Dot]
    | 'I' | 'i' -> [Dot; Dot]
    | 'J' | 'j' -> [Dot; Dash; Dash; Dash]
    | 'K' | 'k' -> [Dash; Dot; Dash]
    | 'L' | 'l' -> [Dot; Dash; Dot; Dot]
    | 'M' | 'm' -> [Dash; Dash]
    | 'N' | 'n' -> [Dash; Dot]
    | 'O' | 'o' -> [Dash; Dash; Dash]
    | 'P' | 'p' -> [Dot; Dash; Dash; Dot]
    | 'Q' | 'q' -> [Dash; Dash; Dot; Dash]
    | 'R' | 'r' -> [Dot; Dash; Dot]
    | 'S' | 's' -> [Dot; Dot; Dot]
    | 'T' | 't' -> [Dash]
    | 'U' | 'u' -> [Dot; Dot; Dash]
    | 'V' | 'v' -> [Dot; Dot; Dot; Dash]
    | 'W' | 'w' -> [Dot; Dash; Dash]
    | 'X' | 'x' -> [Dash; Dot; Dot; Dash]
    | 'Y' | 'y' -> [Dash; Dot; Dash; Dash]
    | 'Z' | 'z' -> [Dash; Dash; Dot; Dot]
    | ' ' -> [Space]
    | _ -> raise <| new ArgumentException("Invalid char")

let ConvertStringToMorse str =
    str |> List.ofSeq |> List.map ConvertCharToEnglishChar |> List.concat

let ConvertMorseCharToString = function
    | Dot -> '.'
    | Dash -> '_'
    | Space -> ' '

let ConvertMorseListToString morse =
    morse |> List.map ConvertMorseCharToString |> Seq.ofList |> string





