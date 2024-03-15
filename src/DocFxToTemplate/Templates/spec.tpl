{{- if $1.spec_csharp?.size > 0 -}}
    {{- for ref in $1.spec_csharp -}}
        {{- if ref.item -}}
    [{{ ref.name | md.escape }}]({{ ref.item.link.absolute_address }})
        {{- else if ref.href && ref.is_external -}}
    [{{ ref.name | md.escape }}]({{ ref.href }})
        {{- else -}}
    {{ ref.name | md.escape }}
        {{- end -}}
    {{- end -}}
{{- else -}}
  {{- $1 | md.ref_link -}}
{{- end -}}