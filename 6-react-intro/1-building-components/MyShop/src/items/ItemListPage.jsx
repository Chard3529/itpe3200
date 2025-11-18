import React from "react";
import { Table } from 'react-bootstrap';
import vegetables from '../data/items.json';

const ItemListPage= () => {
    
    const items = vegetables;

    return (
        <div>
            <h1>Items</h1>
            <Table striped bordered hover>
            <thead>
                <tr>
                    <th>ID</th>
                    <th>Name</th>
                    <th>Price</th>
                    <th>Description</th>
                    <th>Image</th>
                </tr>
            </thead>
            <tbody>
                {items.map( item => (
                    <tr key={item.ID}>
                        <td>{item.ID}</td>
                        <td>{item.Name}</td>
                        <td>{item.Price}</td>
                        <td>{item.Description}</td>
                        <td><img src={item['IMG-url']} alt={item.Name} width="120"/></td>
                    </tr>
                ))}
            </tbody>
            </Table>
        </div>
    );
};

export default ItemListPage;
