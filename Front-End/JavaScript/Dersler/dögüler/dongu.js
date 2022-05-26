const PRODUCTS =  ["İşlemci","Ekran Kartı","Ram","Ana kart","Fan","Batarya"]


//foreach() kullanımı
PRODUCTS.forEach( product => console.log(product))

PRODUCTS.forEach( (product2,index) => console.log(`${product2} ${index}`))


// filter() kullanımı 
const USERS = [
    {fullName: "Mehmet Doğanay" , isActive: true},
    {fullName: "Elifnur Akcr" , isActive: true},
    {fullName: "Ayşe D" , isActive: false},
    {fullName: "Burak D" , isActive: false},
]

const ACTIVE_USER = USERS.filter(user => user.isActive)
console.log(ACTIVE_USER)

// filter() örnek

var product = PRODUCTS.filter(item => item.length > 5)
console.log(product)


// filter() örnek2

const PERSON = [{
    name: "Adem",
    age: 25,
    languages: ["JavaScript", "CSS"],
  },
  {
    name: "Oğuz",
    age: 33,
    languages: ["Java", "HTML"],
    }
  ];

const biggestPerson = PERSON.filter(person => person.age > 30)
console.log(biggestPerson)

const jsDeveloper = PERSON.filter((person, index) => person.languages[index] == "JavaScript")
console.log(jsDeveloper)

// map() kullanımı

const USERS_TWO = ["AYSE","MehMet","ElİF","DOganay"]

const NEW_USERS = USERS_TWO.map(user => user.toLocaleLowerCase())
console.log(NEW_USERS)

// const USERS_OBJECT = USERS_TWO.map( item => 
//     { 
//      return{userName:  item , shortName: `${item[0].toUpperCase()}.`, newName: `${item[0].toUpperCase()}${item.slice(1).toLowerCase()}`} 
//     }
// )

const USERS_OBJECT = USERS_TWO.map( item => 
    ( 
     {userName:  item , shortName: `${item[0].toUpperCase()}.`, newName: `${item[0].toUpperCase()}${item.slice(1).toLowerCase()}`} 
     )
)
   
console.log(USERS_OBJECT)

//map() örnek
const maas = [1100,2000,5000,1500,6000,1750,2350,4500]

const zamlıMaas = maas.map((maas) => {
    if(maas > 3000)
        return maas += maas*1.15
    else
        return maas+= maas *1.25
     }
    )
console.log(zamlıMaas)
