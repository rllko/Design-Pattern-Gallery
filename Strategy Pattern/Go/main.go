package main

import (
	"github.com/rllko/Strategy-Pattern/ducks"
)

func main() {
	var duck ducks.Duck

	duck = ducks.NewMallardDuck()
	duck.Display()
	duck.Fly()

	duck = ducks.NewModelDuck()
	duck.Display()
	duck.Fly()
	ducks.NewMallardDuck()
}
