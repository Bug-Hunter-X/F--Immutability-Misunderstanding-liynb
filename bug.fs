let mutable x = 0
let addOne x = x + 1
let y = addOne x
printf "%d %d" x y // this will print 0 1, not 1 1 as expected because of immutability