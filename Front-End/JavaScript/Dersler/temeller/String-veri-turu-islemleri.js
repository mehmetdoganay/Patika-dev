// *******************String veri Türü işlemleri*************************
let mail = "mehmetdganay@gmail.com"
let firstName = "mehmet"
let lastName = "doğanay"


// String karakter sayısı  = lenght 
console.log(mail.length)

// ilk karakteri bulmak --> [0] 
console.log(firstName[0])
console.log(firstName.charAt(1))

// büyük harf küçük harf yapmak
firstName = firstName.toUpperCase()
console.log(firstName)

firstName = firstName.toLowerCase()
console.log(firstName)

// string içinde istediğimiz yeri bilgiyi ve yeri bulmak --> search
console.log(mail.search("@"))
console.log(mail[12])
//Not olmayan bir değer aratılırsa -1 döner!

// Belli bir yerden sonrasını alma
let DOMAIN = mail.slice(mail.search("@"))
console.log(DOMAIN)

DOMAIN = mail.slice(mail.search("@")+1)
console.log(DOMAIN)

DOMAIN= mail.slice(mail.indexOf("m") , mail.search("@"))
console.log(DOMAIN)

// bilgiyi değiştir --> replace
mail = mail.replace("gmail.com","outlook.com") // ilk değer değiştirmek istenen değer 2. değer yerine gelecek değer
console.log(mail)

// istediğim bilgi var mı ? includes 
console.log(mail.includes("@")) // true döner
console.log(mail.includes("mehmet")) // true
console.log(mail.includes("ö")) // false

// istediğim bilgi ile başlayıp bittimi ?
console.log(mail.startsWith("me")) // true
console.log(mail.endsWith("com")) // true 

console.log(mail.startsWith("com")) // false
console.log(mail.endsWith("t")) // false

// ilk harflerini büyük yapmak

console.log(firstName[0].toUpperCase() + firstName.slice(1) +" "+ lastName[0].toUpperCase() + lastName.slice(1) )

