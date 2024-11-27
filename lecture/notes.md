DNS 
- what's the address in a form humans can understand
- looks first in host file
- local network next
- then ISP
- --> --> root servers
- ...
- cache results for specified time

loading up a new url causes this all to run the first time

4 layer model (which are all 'directional'- has a specified order of receiving or sending)
(7 technically)
Application --> HTTP
Transport --> TCP/UDP
Internet --> IP
Network --> Mac (Medium access control) address 

*see image in glean*

gateway
network layer sent to gateway
gateway has list of how internet is layed out
gateway looks it up

 Network (11:49)
 IP is how you get messages across multiple computers

 IP Routing
 a bit of rendomness to help regulate traffic
 no guarantee that your packet will make it to its destination
 

 NAT - Network Address Translation
 - can be layered as things get more complicated
 NAT Gateway has IP publicly routable
 everything behind it has private IP
 certain IP addresses are reserved for private use to avoid conflict with public IP addresses

TCP
to send packets securely
verifying that data will transfer as expected
connection is sort of recreated every time http request 

UDP
without verification
when losing a packet doesn't matter that much
for latency dependent programs (when speed is more crucial than complete data transfer)
(small skip in a video vs buffering until everything is fully loaded)

HTTP
has enough data for everyone else to do there job