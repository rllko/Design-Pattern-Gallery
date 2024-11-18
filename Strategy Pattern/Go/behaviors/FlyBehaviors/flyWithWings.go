package FlyBehavior

import "fmt"

type FlyWithWings struct{}

func (behavior FlyWithWings) Fly() {
	fmt.Println("FLYING WITH WINGS OMG")
}
