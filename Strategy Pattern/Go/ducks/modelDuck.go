package ducks

import (
	"fmt"

	"github.com/rllko/Strategy-Pattern/behaviors/FlyBehaviors"
)

type modelDuck struct {
	flyBehavior FlyBehavior.IFlyBehavior
}

func NewModelDuck() *modelDuck {
	return &modelDuck{flyBehavior: FlyBehavior.FlyNowhere{}}
}

func (m *modelDuck) Fly() {
	m.flyBehavior.Fly()
}

func (m *modelDuck) Display() {
	fmt.Println("model duck quack")
}
