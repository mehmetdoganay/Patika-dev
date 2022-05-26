var counter = 0
const increase = document.querySelector("#increase")
const decrease = document.querySelector("#decrease")

var counterDom = document.querySelector("#counter")



increase.addEventListener("click",getCounter)
decrease.addEventListener("click",getCounter)

function getCounter() {
    console.log(this.id)
    this.id == "increase" ? counter += 1 : counter -= 1
    counterDom.innerHTML = counter

}