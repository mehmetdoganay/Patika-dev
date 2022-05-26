
let submitForm = document.querySelector("#userForm")
submitForm.addEventListener("submit", formHandler )
const alertDom = document.querySelector("#alert")

const alertFunction = (title ,message) => `<div class="alert alert-danger alert-dismissible fade show" role="alert">
<strong>${title}</strong> ${message}
<button type="button" class="close" data-dismiss="alert" aria-label="Close">
  <span aria-hidden="true">&times;</span>
</button>
</div>`

function formHandler(event)  {
    event.preventDefault()
    const userName = document.querySelector("#InputUserName")
    const userNum = document.querySelector("#InputNum")
    if(userName.value && userNum.value) {
        addItem(userName.value,userNum.value)
        userName.value = ""
        userNum.value = ""
    }
    else
    {
        alertDom.innerHTML = alertFunction(
            "Başlık",
            "Eksik bilgi girdiniz."
            )
    }
}

let userList = document.querySelector("#userInfo")
const addItem = (userName,userNum) => {
    let liDom = document.createElement("li")
    liDom.innerHTML = `${userName} ${userNum}`
    liDom.classList.add("list-group-item","disabled")
    userList.append(liDom)
}
