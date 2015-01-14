open Cars

[<EntryPoint>]
let main args =
    printfn "hello world!"
    printfn "how are you today ?"

    //let response = System.Console.ReadLine()
    //printfn "great to hear you are %s" response

    printfn "add 1 + 2 = %i" (Calculator.add 1 2)

    let car = Cars.Car()
    car.Move()

    let greenCar = Cars.Car("green", 6, CarType.truck)
    greenCar.Move()
    printfn "calc type %A" greenCar.CarTypeCalcuated

    printfn "Hit any key to exit !"
    let responses = System.Console.ReadLine()

    0