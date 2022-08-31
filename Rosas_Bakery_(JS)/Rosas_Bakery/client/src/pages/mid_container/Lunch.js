import React from 'react'
import {useState} from 'react'
import Lunch from '../../resources/json_files/lunch.json'
import Button from '../../local_storage/data_receivers/Button';
import './styles/Mid_Container.css'

function Mid_Container() {
    const [items] = useState(Lunch);

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
