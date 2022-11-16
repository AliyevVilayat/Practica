fetch('https://jsonplaceholder.typicode.com/photos')
  .then((response) => response.json())
  .then((data) => testMethod(data));

  function testMethod(data){

    let value ="testValue";
    let key ="id";
    let str = data[0][key];

    console.log(str);

  }