module Tests

open System
open Xunit
open Library.KataProblem

[<Fact>]
let empty_string_test () =
    Assert.Equal("", text_to_morse(""))

[<Fact>]
let one_letter_test () =
    Assert.Equal("-", text_to_morse("T"))

[<Fact>]
let one_word_test () =
    Assert.Equal("- --- -.. .- -.--", text_to_morse("Today"))

[<Fact>]
let sentence_test () =
    Assert.Equal("- --- -.. .- -.-- / .. ... / .-. .- .. -. -.-- .-.-.-", text_to_morse("Today is rainy."))

[<Fact>]
let full_text_test () =
    Assert.Equal("- .... . / .-- . .- - .... . .-. / .. ... / .-. . .- .-.. .-.. -.-- / --. --- --- -.. / - --- -.. .- -.-- .-.-.- / .-- --- ..- .-.. -.. / -.-- --- ..- / .-.. .. -.- . / - --- / --. --- / ..-. --- .-. / .- / .--. .. -.-. -. .. -.-. ..--..", 
        text_to_morse("The weather is really good today. Would you like to go for a picnic?"))
  
