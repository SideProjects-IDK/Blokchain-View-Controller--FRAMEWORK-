require "net/http"

c = Net::HTTP::Client.new

res = c.send do |req|
  req.url = "https://361D8083311C7D272D2F7AFE819ECD3DB63EA317677533A5EAE264A9CC53B888.onion/projects/0xddf73/blockchain/json/0x6d73a"
  req.method = "GET"
end

puts res.body