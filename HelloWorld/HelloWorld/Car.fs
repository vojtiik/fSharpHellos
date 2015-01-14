module Cars

type CarType =
    | car = 1
    | racer = 2
    | truck = 0
    | sickCar = 3

type Car(color:string, wheelCount: int, carType : CarType) =
    do if wheelCount < 3 then failwith "that's not a car"
  
    new() = Car("red",4, CarType.racer)

    member x.Move() = printfn "The %s car %A is moving" color carType 

    member x.CarTypeCalcuated =  
        match wheelCount with
            | 4 -> CarType.car
            | 6 -> CarType.truck
            | 8 -> CarType.racer
            | x when x > 8 -> CarType.sickCar
            | _ -> CarType.sickCar