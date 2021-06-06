module Library

open System.Collections.Generic

let dict : IDictionary<char, string> =
                [ 
                    'A',".-"; 'B',"-...";
                    'C',"-.-."; 'D',"-.."; 'E',".";
                    'F',"..-."; 'G',"--."; 'H',"....";
                    'I',".."; 'J',".---"; 'K',"-.   -";
                    'L',".-.."; 'M',"--"; 'N',"-.";
                    'O',"---"; 'P',".--."; 'Q',"--.-";
                    'R',".-."; 'S',"..."; 'T',"-";
                    'U',"..-"; 'V',"...-"; 'W',".--";
                    'X',"-..-"; 'Y',"-.--"; 'Z',"--..";
                    '1',".----"; '2',"..---"; '3',"...--";
                    '4',"....-"; '5',"....."; '6',"-....";
                    '7',"--..."; '8',"---.."; '9',"----.";
                    '0',"-----"; ',', "--..--"; '.',".-.-.-";
                    '?',"..--.."; '/',"-..-."; '-',"-....-";
                    '(',"-.--."; ')',"-.--.-"; ' ', "/"
                ] |> dict

module KataProblem =
    let text_to_morse text =
        let mutable morse_text = ""
        for character in text do
            let morse_translation = dict.[System.Char.ToUpper character]
            morse_text <- morse_text + morse_translation + " "
        morse_text.TrimEnd()
