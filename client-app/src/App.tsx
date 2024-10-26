import { useEffect, useState } from 'react'
import './App.css'
import axios from 'axios'
import { Header , ListItem , List } from 'semantic-ui-react'


function App() {
   const [activities, setActivities] = useState([])  //assign array to activities//

   useEffect(() => {
      axios.get('http://localhost:5000/api/Activities')
         .then(response => {
            console.log(response)
            setActivities(response.data)
         })

   }, [])

   return (
      <div>
         <Header as='h2' icon='users' content='Reactivities' />
         
         <List>
            {activities.map((activity: any) => (
               <ListItem key={activity.id}>
                  {activity.title}
               </ListItem>

            ))}
        </List>
      </div>

   )
}
export default App