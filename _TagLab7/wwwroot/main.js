function addAddress() {
    const Name = 'Миладзе';
    const Description = 'новогоднее выступление';
    const Category = 'поп';
    const Price = '7000';
    axios.get(`http://localhost:5106/addAddr?Name=${Name}&Description=${Description}&Category=${Category}&Price=${Price}`, (res) => {
        console.log(res);
    });
}