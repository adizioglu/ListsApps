// string[] firstNames = new string[5]
let firstNames = System.Collections.Generic.List<string>()

firstNames.Add("Tim")
firstNames.Add("Sue")
firstNames.Add("Bob")
firstNames.Add("Jane")
firstNames.Add("Frank")

printfn "%s" (firstNames.[firstNames.Count - 1])

let ages = System.Collections.Generic.List<int>()
ages.Add(1)
ages.Add(2)
ages.Add(3)

// List<T> - generic

let data = "Corey,Smith,Jones"
let lastNames = data.Split(',') |> List.ofArray |> System.Collections.Generic.List<string>
lastNames.Add("Franklin")


