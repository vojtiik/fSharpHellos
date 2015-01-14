module Calculator.Tests

open Xunit

[<Fact>]
let adder_add_1_2_should_return_3() =
    Assert.Equal(3, Calculator.add 1 2)

