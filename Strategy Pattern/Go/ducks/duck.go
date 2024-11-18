package ducks

import "github.com/rllko/Strategy-Pattern/behaviors/FlyBehaviors"

type Duck interface {
	FlyBehavior.IFlyBehavior
	Display()
}
