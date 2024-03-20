---
title: {{ model.type }} {{ model.name }}
sidebar_label: {{ model.name }}
description: TODO
---

# {{ model.type }} {{ model.name | md.escape }}
Namespace: {{ model.namespace_name }}   
Assembly: {{ model.assembly_name_list[0] }}.dll  
{{~ source_repo_link = model.source | md.source_repo_link ~}}
{{~ if source_repo_link ~}} Source: {{ source_repo_link }} {{~ end ~}}
    
{{~ model.summary | md.summary }}   

{{~ if model.syntax?.content -}}
    ```csharp title="{{ model.source?.path }}#L{{ model.source?.start_line + 1 }}" 
    {{~ model.syntax?.content }}
    {{~ }}```
{{~ end ~}}

{{~ if model.inheritance_refs?.size > 0 -}}
**Inheritance:**   
    {{~ for item in model.inheritance_refs -}}
        {{~ item | md.ref_link }} &lt;- 
    {{~ end -}}
{{- model | md.item_link -}}
{{- end }}   

{{~ if model.inherited_members?.size > 0 -}}
**Inherited Members:**   
    {{~ for item in model.inherited_members_refs -}}
        {{- item | md.ref_link -}}
        {{- if for.index != (model.inherited_members.size - 1) }}, {{ end -}}
    {{- end -}}
{{- end }}   

{{~ if model.derived_classes?.size > 0 -}}
**Derived:**   
    {{~ if model.derived_classes?.size > 8 -}}
    <details>
        <summary>Expand</summary>
    {{- end -}}
    
    {{- for item in model.derived_classes -}}
        {{- item | md.escape -}}
        {{- if for.index != (model.derived_classes.size - 1) }}, {{ end -}}
    {{- end -}}
    
    {{- if model.derived_classes?.size > 8 -}}
        </details>
    {{- end -}}
{{- end }}   

{{- if model.implements?.size > 0 -}}
**Implements:**   
    {{~ if model.implements?.size > 8 -}}
    <details>
    <summary>Expand</summary>
    {{- end -}}
    {{- for item in model.implements -}}
        {{- item | md.escape -}}
        {{- if for.index != (model.implements.size - 1) }}, {{ end -}}
    {{- end -}}
    {{- if model.implements?.size > 8 -}}
        </details>
    {{- end -}}
{{- end }}   

{{~ if model.properties?.size > 0 -}}
    ## Properties
    {{~ for item in model.properties -}}
        ### {{ item.name | md.escape }}
        {{~ item.summary | md.summary }}   
            
        {{~ if item.syntax?.content -}}
            ```csharp title="{{ item.source?.path }}#L{{ item.source?.start_line + 1 }}"
            {{~ item.syntax?.content }}
            {{~ }}```
        {{- end }}   

        {{~ if item.syntax?.return -}}
            #### Property value
            {{~ include 'spec.tpl' item.syntax.return.reference }}   
            {{~ item.syntax?.return.description }}   
        {{~ end ~}}
    {{~ end ~}}
{{~ end }}   

{{~ if model.fields?.size > 0 -}}
    ## Fields
    {{~ for item in model.fields -}}
        ### {{ item.name }}
        {{~ item.summary | md.summary }}   

        {{~ if item.syntax?.content -}}
            ```csharp title="{{ item.source?.path }}#L{{ item.source?.start_line + 1 }}"
            {{~ item.syntax?.content }}
            {{~ }}```
        {{~ end ~}}
        
        {{~ if item.syntax?.return -}}
            #### Field value
            {{~ include 'spec.tpl' item.syntax.return.reference }}   
            {{~ item.syntax?.return.description }}   
        {{~ end ~}}
    {{~ end ~}}
{{~ end }}   

{{~ if model.methods?.size > 0 -}}
    ## Methods
    {{~ for item in model.methods -}}
        ### {{ item.name | md.escape }}
        {{~ item.summary | md.summary }}   
        {{~ if item.syntax?.content -}}
            ```csharp title="{{ item.source?.path }}#L{{ item.source?.start_line + 1 }}"
            {{~ item.syntax?.content }}
            {{~ }}```
        {{~ end ~}}

        {{~ if item.syntax.parameters?.size > 0 ~}}
        {{~ }}#### Parameters
            {{~ for parameter in item.syntax.parameters -}}
                `{{ parameter.name }}` {{ parameter.reference | md.ref_link }}   
                {{~ parameter.description  }}   
            {{~ end -}}
        {{~ end -}}    

        {{~ if item.syntax?.return != null ~}}
        {{~ }}#### Returns
            {{~ item.syntax.return.name | md.escape }} {{ item.syntax.return.reference | md.ref_link }}    
            {{~ item.syntax.return.description }}   
        {{~ end ~}}

    {{~ end ~}}
{{~ end }}   

{{~ if model.events?.size > 0 -}}
    ## Events
    {{~ for item in model.events -}}
        ### {{ item.name | md.escape }}
    {{~ end ~}}
{{~ end }}   

{{~ if model.implements?.size > 0 -}}
    ## Implements
    {{~ for item in model.implements -}}
        * {{ item | md.escape }}
    {{~ end ~}}
{{~ end }}   

{{~ if model.extension_methods?.size > 0 -}}
    ## Extension Methods
    {{~ for item in model.extension_methods -}}
        * {{ item | md.escape }}
    {{~ end ~}}
{{~ end }}   