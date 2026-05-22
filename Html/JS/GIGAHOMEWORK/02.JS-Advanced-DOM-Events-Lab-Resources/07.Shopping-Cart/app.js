function solve() {
   let shoppingCart = document.querySelector('.shopping-cart');
   let result = document.querySelector('textarea');
   let checkoutButton = document.querySelector('.checkout');

   let cart = {
      products: [],
      totalPrice: 0,
      add: function(product) {
         this.products.push(product);
         this.totalPrice += product.price;
         result.value += `Added ${product.name} for ${product.price.toFixed(2)} to the cart.\n`;
      },
      checkout: function() {
         let uniqueProducts = [...new Set(this.products.map(p => p.name))];
         result.value += `You bought ${uniqueProducts.join(', ')} for ${this.totalPrice.toFixed(2)}.`;
         shoppingCart.removeEventListener('click', onClick);
         checkoutButton.removeEventListener('click', onCheckout);
      }
   };

   shoppingCart.addEventListener('click', onClick);
   checkoutButton.addEventListener('click', onCheckout);

   function onClick(ev) {
      if (ev.target.classList.contains('add-product')) {
         let productElement = ev.target.parentElement.parentElement;
         let name = productElement.querySelector('.product-title').textContent;
         let price = Number(productElement.querySelector('.product-line-price').textContent);
         cart.add({ name, price });
      }
   }

   function onCheckout() {
      cart.checkout();
   }
}