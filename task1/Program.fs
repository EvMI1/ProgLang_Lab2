open System

let InputUserString n =
    let ls = 
        [
            for i=1 to n do
                printf "Введите строку: "
                let s = Console.ReadLine()
                yield s
        ]
    ls

[<EntryPoint>]
let main _ =
    printf "Введите размер списка: "
    let size = int(Console.ReadLine())
    if size <= 0 then
        failwith "ОШИБКА: неккоректный размер списка"
    printfn "Заполните список"
    let ls = InputUserString size
    printf "Введите символ, который добавить к строкам\n(вводится 1 символ, все остальные символы после первого читаться не будут)\n: "
    let symb = Console.ReadLine()[0]
    let new_ls = List.map (fun s -> s + string symb) ls
    printfn "Новый список: %A" new_ls
    0