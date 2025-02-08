let mutable x = 0
let addOne x = x + 1
let y = addOne x
printf "%d %d" x y // prints 0 1
x <- addOne x // this will properly update x
printf "%d %d" x y // now this will print 1 1
//Alternative using let for reassignment within a scope:
let x = 0
let y = x + 1
printf "%d %d" x y // still prints 0 1
let x = y
printf "%d %d" x y // now this will print 1 1