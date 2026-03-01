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
    if size = 0 then
        printfn "Вы ввели пустой список!"
    elif size < 0 then
        failwith "Размер списка не может быть отрицательным!"
    else
        printfn "Заполните список"
        let ls = InputUserString size
        printf "Введите символ, который добавить к строкам: "
        let symb = Console.ReadLine()
        let new_ls = List.map (fun s -> s + symb) ls
        printfn "Новый список: %A" new_ls
    0