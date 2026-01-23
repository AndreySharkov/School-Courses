function solve() {
   document.querySelector('#btnSend').addEventListener('click', onClick);

   function onClick () {
      const input = document.querySelector('#inputs textarea');
      const arr = JSON.parse(input.value);
      const restaurants = {};

      for (const line of arr) {
         const [name, workersStr] = line.split(' - ');
         const workers = workersStr.split(', ').map(w => {
            const [workerName, salary] = w.split(' ');
            return { name: workerName, salary: Number(salary) };
         });

         if (!restaurants[name]) {
            restaurants[name] = { workers: [], averageSalary: 0, bestSalary: 0 };
         }
         
         restaurants[name].workers = restaurants[name].workers.concat(workers);
         
         const salaries = restaurants[name].workers.map(w => w.salary);
         restaurants[name].bestSalary = Math.max(...salaries);
         const totalSalary = salaries.reduce((a, b) => a + b, 0);
         restaurants[name].averageSalary = totalSalary / salaries.length;
      }

      let bestRestaurant = undefined;
      let bestAvgSalary = 0;

      for (const name in restaurants) {
         if (restaurants[name].averageSalary > bestAvgSalary) {
            bestAvgSalary = restaurants[name].averageSalary;
            bestRestaurant = { name, ...restaurants[name] };
         }
      }

      const bestRestaurantP = document.querySelector('#bestRestaurant p');
      bestRestaurantP.textContent = `Name: ${bestRestaurant.name} Average Salary: ${bestRestaurant.averageSalary.toFixed(2)} Best Salary: ${bestRestaurant.bestSalary.toFixed(2)}`;

      const workersP = document.querySelector('#workers p');
      bestRestaurant.workers.sort((a, b) => b.salary - a.salary);
      const workersOutput = bestRestaurant.workers.map(w => `Name: ${w.name} With Salary: ${w.salary}`).join(' ');
      workersP.textContent = workersOutput;
   }
}