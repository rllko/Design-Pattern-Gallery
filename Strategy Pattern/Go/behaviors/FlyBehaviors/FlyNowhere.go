package FlyBehavior

import "fmt"

type FlyNowhere struct{}

func (behavior FlyNowhere) Fly() {
	fmt.Println("flying but nowhere, dw about me!")
}
