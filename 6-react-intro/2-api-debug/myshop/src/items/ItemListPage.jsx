import React, { useState } from 'react';
import { Table, Button } from 'react-bootstrap';

import ItemTable from './ItemTable';

const API_URL = 'http://localhost:5043'

const ItemListPage= () => {
  const [items, setItems] = useState([]);
  const [loading, setLoading] = useState(false);
  const [error, setError] = useState(null);

  const fetchItems = async () => {
    setLoading(true);
    setError(null);

    try {
      const response = await fetch(`${API_URL}/api/itemapi/itemlist`);
      if (!response.ok) {
        throw new Error('Network response was not ok');
      }

      const data = await response.json()
      setItems(data);
      console.log(data);
    }

    catch (error) {
      console.error(`There was a problem with the fetch operation ${error.message}`);
      setError('Failed to fetch items');
    }

    finally {
      setLoading(false)
    }
  };


  return (
    <div>

      <h1>Items</h1>
      <Button onClick={fetchItems} className="btn btn-primary mb-3" disabled={loading}>
        {loading ? 'Loading...' : 'Refresh Items'}
      </Button>

      {error && <p style={{color: 'red'}}>{error}</p>}

      <ItemTable items={items} apiUrl={API_URL} />

    </div>
  );
};

export default ItemListPage;
