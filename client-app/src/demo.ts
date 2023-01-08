interface Duck {
    name : string;
    numLegs: number;
    makeSound?: (sound: string)=> void; // optional
}

const duck1: Duck = {
    name:"jack",
    numLegs: 2,
    makeSound:(sound:any)=> console.log(sound)
}

const duck2: Duck ={
    name: "Hal",
    numLegs: 2,
    makeSound:( sound:any)=> console.log(sound)
}

duck1.makeSound!("quack")

export{}