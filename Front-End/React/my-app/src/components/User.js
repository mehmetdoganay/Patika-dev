import PropTypes from "prop-types";

function User({name, surname, heigh, isLoggedIn, age, friends, adress}) {
    return (
        <>
            <h1>
                {
                    isLoggedIn ? `Hey I am ${name} ${surname} ${heigh} CM ${age} Years old` : `Giriş Yapılmadı`
                }
            </h1>
            
            {
                adress.map((adres,index) => (
                    <div key={index}>
                       {adres.name}
                    </div>
                ))
            }

            {
                friends.map((friend,id) => (
                <div key={id}> {friend.id} -- {friend.name} </div>))
            }
        </>
    );
}

// Prop tiplerini belirtildi
User.propTypes = {
    name: PropTypes.string.isRequired, // isRequired doldurulması zorunlu alanı gösterir.
    surname: PropTypes.string,
    heigh: PropTypes.number,
    isLoggedIn: PropTypes.bool,
    age: PropTypes.oneOfType([PropTypes.string,PropTypes.number]), // oneOfType ile değişkeni 2 farklı değer tipi olarak gösterebiliriz.
    friends: PropTypes.array,
    adress: PropTypes.shape({
        title: PropTypes.string,
        zipt: PropTypes.number
    }),
}

export default User