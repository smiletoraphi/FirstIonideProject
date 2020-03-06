
open System

module testModule=
    let estimateAges(familyName, year1, year2, year3) =
        let calculateAge(yearOfBirth) =
            let year = DateTime.Now.Year
            year - yearOfBirth
            
        let averageAge = (calculateAge(year1) + calculateAge(year2) + calculateAge(year3)) / 3
        sprintf "Average age of family %s is %d years" familyName averageAge

[<EntryPoint>]
let main argv =
    printfn "OUTPUT: %s"  (testModule.estimateAges("Friedli", 1959, 1986, 1994))

    0