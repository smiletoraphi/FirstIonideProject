
open System

module testModule=
    let estimateAges(familyName, year1, year2, year3) =
        let calculateAge(yearOfBirth) =
            let year = DateTime.Now.Year
            year - yearOfBirth
            
        let estimate1 =  calculateAge(year1)
        let estimate2 =  calculateAge(year2)
        let estimate3 =  calculateAge(year3)
        let averageAge = (estimate1 + estimate2 + estimate3) / 3
        sprintf "Average age of family %s is %d years" familyName averageAge

[<EntryPoint>]
let main argv =

    printfn "OUTPUT: %s"  (testModule.estimateAges("Friedli", 1959, 1986, 1995))

    0