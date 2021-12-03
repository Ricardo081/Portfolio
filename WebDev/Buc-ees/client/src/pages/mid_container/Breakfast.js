import React from 'react'
import {useState} from 'react'
import Breakfast from '../../resources/json_files/breakfast.json'
import Button from '../../local_storage/data_receivers/Button';
import './styles/Mid_Container.css'

function Mid_Container() {
    const [items] = useState(Breakfast);

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
