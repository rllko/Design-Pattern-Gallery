package ducks

import (
	"fmt"

	"github.com/rllko/Strategy-Pattern/behaviors/FlyBehaviors"
)

type mallardDuck struct {
	flyBehavior FlyBehavior.IFlyBehavior
}

func NewMallardDuck() *mallardDuck {
	return &mallardDuck{flyBehavior: FlyBehavior.FlyWithWings{}}
}

func (m *mallardDuck) Fly() {
	m.flyBehavior.Fly()
}

func (m *mallardDuck) Display() {
	fmt.Println("MALlARD BRO!!!!!")
}
