{{~ first_value = true -}}
{{~ for c in generator_context.items 
    if model.name != c.namespace_name || c.type != $2
        continue
    end
-}}
    {{~ if first_value -}}
        ## {{ $1 }}
    {{~ first_value = false ~}}
    {{~ end -}}

   ### {{ c | md.item_link }}
   {{~ c.summary | md.summary }}
{{~ end }}