const neck = document.getElementById('neck');
const chest = document.getElementById('chest');
const waist = document.getElementById('waist');
const sleeve = document.getElementById('sleeve');
const waistTrousers = document.getElementById('waist-trousers');
const inseam = document.getElementById('inseam');

const form = document.querySelector('form');
form.addEventListener('submit', calculatePrice);

function calculatePrice(event) {
    event.preventDefault();

    const shirtPrice = 20;
    const trousersPrice = 25;

    const shirtTotal = (neck.value * 0.5) + (chest.value * 0.5) + (waist.value * 0.5) + (sleeve.value * 0.5);
    const trousersTotal = (waistTrousers.value * 0.5) + (inseam.value * 0.5);

    const total = shirtTotal + trousersTotal;
    const totalPrice = shirtTotal * shirtPrice + trousersTotal * trousersPrice;

    console.log(`Total measurements: ${total}`);
    console.log(`Total price: ${totalPrice}`);
}
