open System

let InputUserString n =
    printfn "Заполните список"
    let ls = 
        [
            for i=1 to n do
                printf "Введите строку: "
                let s = Console.ReadLine()
                yield s
        ]
    ls

let shortest_string (ls: string list) =
    List.fold (fun (acc:string) (s:string) -> 
    if s.Length < acc.Length then s else acc) 
        ls.Head ls.Tail

[<EntryPoint>]
let main _ =
    printf "Введите размер списка: "
    let size = int(Console.ReadLine())
    if size <= 0 then
        failwith "ОШИБКА: неккоректный размер списка"
    let ls = InputUserString size
    printfn "Кротчайшая строка: %A" (shortest_string ls)
    0