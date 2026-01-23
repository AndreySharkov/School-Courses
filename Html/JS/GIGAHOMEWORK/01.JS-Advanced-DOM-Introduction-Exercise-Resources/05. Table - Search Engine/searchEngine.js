function solve() {
   document.querySelector('#searchBtn').addEventListener('click', onClick);

   function onClick() {
      const searchInput = document.getElementById('searchField');
      const searchText = searchInput.value.toLowerCase();
      const rows = document.querySelectorAll('tbody tr');

      Array.from(rows).forEach(row => {
         row.classList.remove('select');
         if (searchText !== '' && row.textContent.toLowerCase().includes(searchText)) {
            row.classList.add('select');
         }
      });

      searchInput.value = '';
   }
}