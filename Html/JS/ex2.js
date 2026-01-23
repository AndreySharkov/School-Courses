function inventory(input)
{
    let items = input.shift().split(', ');
    for(let i = 0; i < input.length; i++){
        let command = input[i].split(" - ")[0]
        if(command == "Craft!"){
            break;

        }
        else if(command === 'Collect'){
            let item = input[i].split(' - ')[1];
            if(!items.includes(item)){
                items.push(item);
            }
        }
        else if(command === 'Drop'){
            let item = input[i].split(' - ')[1];
            if(items.includes(item)){
                let index = items.indexOf(item);
                items.splice(index, 1);
            }
        }
        else if(command === 'Combine Items'){
            let temp = input[i].split(' - ')[1];
            let oldItem = temp.split(':')[0];
            let newItem = temp.split(':')[1];
            if(items.includes(oldItem)){
                let index = items.indexOf(oldItem);
                items.splice(index + 1, 0, newItem);
            }
        }
        else if(command === 'Renew'){
            let item = input[i].split(' - ')[1];
            if(items.includes(item)){
                let index = items.indexOf(item);
                let temp = items.splice(index, 1);
                items.push(temp);
            }
        }
    }
    console.log(items.join(', '));
}
inventory(['Iron, Sword','Drop - Bronze','Combine Items - Sword:Bow','Renew - Iron', 'Craft!'])