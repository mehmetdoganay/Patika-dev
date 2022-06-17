function User({name, surname, isLoggedIn, age, friends}) {
    return (
        <>
            <h1>
                {
                    isLoggedIn ? `${name} ${surname} ${age}` : `Giriş Yapılmadı`
                }
            </h1>

            {
                friends.map((friend) => (
                <div key={friends.id}>{friend.id} -{friend.name}</div>))
            }
        </>
    );
}

export default User