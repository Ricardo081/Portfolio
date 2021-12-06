import React from 'react'
import {useState} from 'react'
import Dinner from '../../resources/json_files/dinner.json'
import Button from '../../local_storage/data_receivers/Button';
import './styles/Mid_Container.css'

function Mid_Container() {
    const [items] = useState(Dinner);

    return (
        
        <div className="Mid_Container">
            {items.map((item) =>
            <Button
            id={item.id}
            itemName={item.item}
            price={item.price}
            image={item.image}
            />
            )}
        </div>
       
    )
}

export default Mid_Container
