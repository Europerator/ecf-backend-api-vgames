import { GizmondoGame } from "./GizmondoGame.js";

class GizmondoRepository 
{
    static apiUrl = 'https://localhost:7071/';

    static async fetchGames()
    {
        let r = await fetch(GizmondoRepository.apiUrl + 'gizmondos');
        let j = await r.json();

        for(let g of j) {
            let pArray = g.publisher.split('/');
            let pId = pArray[pArray.length -1];
            let p = await GizmondoRepository.fetchPublisher(pId);
            g.publisher = p.name;
        }

        let result = j.map(g => new GizmondoGame(g));

        console.log(result);

        return result;
    }

    static async fetchPublisher(_id)
    {
        let r = await fetch(GizmondoRepository.apiUrl + 'publishers/' + _id);
        let j = await r.json();
        console.log(j);
        return j;
    }
}

export { GizmondoRepository }