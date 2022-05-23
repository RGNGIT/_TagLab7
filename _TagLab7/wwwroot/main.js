function addAddress() {
    const city = 'Орендыр';
    const street = '123';
    const number = '432';
    axios.get(`http://localhost:5106/addAddr?City=${city}&Street=${street}&Number=${number}`, (res) => {
        console.log(res);
    });
}